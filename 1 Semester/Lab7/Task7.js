var triangle = document.getElementById("triangle");
var square = document.getElementById("square");
var circle = document.getElementById("circle");

triangle.onclick = function(){

    var input = document.getElementById("input").value;

    for (var i = 1; i <= input; i++){

      var div = document.createElement('div');
      div.className = "triangle";
      div.tabIndex = "0";
      document.getElementById('page').appendChild(div);

      div.style.borderBottomWidth = Math.floor(Math.random() * 150) + 20 + 'px';

      div.style.left = Math.floor(Math.random() * 1401) + 100 + 'px';
      div.style.top = Math.floor(Math.random() * 600) + 25 + 'px';

      div.addEventListener('click', function(){this.focus();})
      div.addEventListener('dblclick', function(){this.remove();})
  }
}

square.onclick = function(){
  var input = document.getElementById("input").value;

  for (var i = 1; i <= input; i++){

    var div = document.createElement('div');
    div.className = "square";
    div.tabIndex = "0";
    document.getElementById('page').appendChild(div);

    div.style.width = Math.floor(Math.random() * 150) + 20 + 'px';
    div.style.height = div.style.width;

    div.style.left = Math.floor(Math.random() * 1401) + 100 + 'px';
    div.style.top = Math.floor(Math.random() * 600) + 25 + 'px';

    div.addEventListener('click', function(){this.focus();})
    div.addEventListener('dblclick', function(){this.remove();})
}
}

circle.onclick = function(){
  var input = document.getElementById("input").value;

  for (var i = 1; i <= input; i++){

    var div = document.createElement('div');
    div.className = "circle";
    div.tabIndex = "0";
    document.getElementById('page').appendChild(div);

    div.style.width = Math.floor(Math.random() * 150) + 20 + 'px';
    div.style.height = div.style.width;

    div.style.left = Math.floor(Math.random() * 1401) + 100 + 'px';
    div.style.top = Math.floor(Math.random() * 600) + 25 + 'px';

    div.addEventListener('click', function(){this.focus();})
    div.addEventListener('dblclick', function(){this.remove();})
}
}
