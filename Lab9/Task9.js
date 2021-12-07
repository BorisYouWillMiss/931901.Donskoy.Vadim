class Calculator{
  constructor(previousOperandTextElement ,operandTextElement){
    this.operandTextElement = operandTextElement;
    this.previousOperandTextElement = previousOperandTextElement;
    this.clear();
  }
  clear(){
    this.currentOperand = '0';
    this.previousOperand = '';
    this.operation = undefined;
    this.updateDisplay();
  }
  delete(){
    this.currentOperand = this.currentOperand.slice(0,-1);
    this.updateDisplay();
  }
  appendNumber(number){

    if (number === '.' && (this.currentOperand.includes('.') || this.currentOperand === '')) return

    if (number === '.' && this.currentOperand === '0') this.currentOperand = this.currentOperand.toString() + number.toString();
    else
    if (number === '0' && this.currentOperand === '0' ) return
    else
    if (number != '0' && this.currentOperand === '0') this.currentOperand = number.toString();
    else
    this.currentOperand = this.currentOperand.toString() + number.toString();
  }
  chooseOperation(operation){
    if (this.operation != undefined && this.currentOperand === '') return
    if (this.operation != undefined && this.currentOperand != '') this.compute();

    this.previousOperand = this.currentOperand;
    this.currentOperand = '';
    this.operation = operation;

    if (operation === '+') this.previousOperand += ' + ';

    if (operation === '-') this.previousOperand += ' - ';

    if (operation === '*') this.previousOperand += ' * ';

    if (operation === '/') this.previousOperand += ' / ';

    this.updateDisplay();
  }
  compute(){
    var numberOne = parseFloat(this.previousOperand);
    var numberTwo = parseFloat(this.currentOperand);
    var result

    if (this.operation === '+') result = numberOne + numberTwo;
    if (this.operation === '-') result = numberOne - numberTwo;
    if (this.operation === '/') result = numberOne / numberTwo;
    if (this.operation === '*') result = numberOne * numberTwo;


    this.previousOperand = '';
    this.currentOperand = result.toString();
    this.operation = undefined;
    this.updateDisplay();

  }
  updateDisplay(){
    this.previousOperandTextElement.innerText = this.previousOperand;
    this.operandTextElement.innerText = this.currentOperand; // Stores both current and previous operands
  }
}

const numberButtons = document.querySelectorAll('[data-number]');
const operationButtons = document.querySelectorAll('[data-operation]');
const clearButton = document.querySelector('[data-clear]');
const deleteButton = document.querySelector('[data-delete]');
const equalsButton = document.querySelector('[data-equals]');
const operandTextElement = document.querySelector('[data-operand]');
const previousOperandTextElement = document.querySelector('[data-previous-operand]');

const calculator = new Calculator(previousOperandTextElement, operandTextElement);

clearButton.addEventListener('click', () =>{
  calculator.clear();
})

deleteButton.addEventListener('click', () =>{
  calculator.delete();
})

equalsButton.addEventListener('click', () =>{
  calculator.compute();
})

numberButtons.forEach(button => {
  button.addEventListener('click', () =>{
    calculator.appendNumber(button.innerText);
    calculator.updateDisplay();
  })
})

operationButtons.forEach(button =>{
  button.addEventListener('click', () =>{
    calculator.chooseOperation(button.innerText)
    calculator.updateDisplay();
  })
})
