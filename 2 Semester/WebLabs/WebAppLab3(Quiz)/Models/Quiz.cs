namespace WebAppLab3_Quiz_.Models
{
    using Microsoft.AspNetCore.Html;
    using Microsoft.AspNetCore.Mvc.Rendering;
    public class Quiz
    {

        public int corrects { get; set; }
        public int errors { get; set; }
        public int curQuestion { get; set; }
        public int questNumber { get; set; }
        public bool finished { get; set; }

        public int[] answer { get; set; }
        public int[] numberOne { get; set; }
        public int[] numberTwo { get; set; }

        public string[] userAnswer { get; set; }
        public string[] operation { get; set; }

        public int QuestNum = 4;

        public Quiz()
        {
            finished = false;
            questNumber = QuestNum;
            answer = new int[QuestNum];
            numberOne = new int[QuestNum];
            numberTwo = new int[QuestNum];
            userAnswer = new string[QuestNum];
            operation = new string[QuestNum];

            Random rand = new Random();
            for (int i = 0; i < QuestNum; i++)
            {
                userAnswer[i] = "Not answered";
                operation[i] = "";
                numberOne[i] = rand.Next(10);
                numberTwo[i] = rand.Next(10);
                switch (rand.Next(3))
                {
                    case 0:
                        operation[i] = "+"; answer[i] = numberOne[i] + numberTwo[i]; break;
                    case 1:
                        operation[i] = "-"; answer[i] = numberOne[i] - numberTwo[i]; break;
                    case 2:
                        operation[i] = "*"; answer[i] = numberOne[i] * numberTwo[i]; break;
                    default: break;
                }
            }
            corrects = 0;
            errors = 0;
            curQuestion = 0;
        }

        public void StartQuiz()
        {
            finished = false;
            Random rand = new Random();
            for (int i = 0; i < questNumber; i++)
            {
                userAnswer[i] = "Not answered";
                operation[i] = "";
                numberOne[i] = rand.Next(10);
                numberTwo[i] = rand.Next(10);
                switch (rand.Next(3))
                {
                    case 0:
                        operation[i] = "+"; answer[i] = numberOne[i] + numberTwo[i]; break;
                    case 1:
                        operation[i] = "-"; answer[i] = numberOne[i] - numberTwo[i]; break;
                    case 2:
                        operation[i] = "*"; answer[i] = numberOne[i] * numberTwo[i]; break;
                    default: break;
                }
            }

            corrects = 0;
            errors = 0;
            curQuestion = 0;
        }

        public HtmlString NextQuestion()
        {
            if (curQuestion < questNumber)
            {
                string resultString = numberOne[curQuestion].ToString() + 
                    operation[curQuestion] + numberTwo[curQuestion].ToString() + " = ";

                TagBuilder div = new TagBuilder("div");

                TagBuilder h = new TagBuilder("h1");
                h.InnerHtml.Append("Quiz");

                div.InnerHtml.AppendHtml(h);

                TagBuilder question = new TagBuilder("h3");
                question.InnerHtml.Append(resultString);
                div.InnerHtml.AppendHtml(question);

                var writer = new System.IO.StringWriter();
                div.WriteTo(writer, System.Text.Encodings.Web.HtmlEncoder.Default);

                return new HtmlString(writer.ToString());
            }
            else
            {
                return ShowResults();

            }
        }

        public HtmlString ShowResults()
        {
            TagBuilder div = new TagBuilder("div");

            TagBuilder h = new TagBuilder("h2");
            h.InnerHtml.Append("Right answers ");
            h.InnerHtml.Append(corrects.ToString());
            h.InnerHtml.Append(" out ");
            h.InnerHtml.Append(questNumber.ToString());

            div.InnerHtml.AppendHtml(h);

            TagBuilder list = new TagBuilder("ul");

            for(int i = 0; i < questNumber; i++)
            {
                //li
                TagBuilder row = new TagBuilder("li");
                row.InnerHtml.Append(numberOne[i].ToString());

                string operString = operation[i].ToString();

                row.InnerHtml.Append(operString);
                row.InnerHtml.Append(numberTwo[i].ToString());
                row.InnerHtml.Append(" = ");
                row.InnerHtml.Append(userAnswer[i]);

                list.InnerHtml.AppendHtml(row);
            }

            div.InnerHtml.AppendHtml(list);

            var writer = new System.IO.StringWriter();
            div.WriteTo(writer, System.Text.Encodings.Web.HtmlEncoder.Default);

            return new HtmlString(writer.ToString());
        }
    }
}
