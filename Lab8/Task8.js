var add = document.getElementById("add");
var save = document.getElementById("save");
var fx = document.getElementById("x");

add.onclick = function(){
  var el = document.getElementById("string");
  element = el.cloneNode(true);

  element.querySelector("#input1").value = "";
  element.querySelector("#input2").value = "";

  document.getElementById('container').appendChild(element);

  var x = element.querySelector("#x");
  x.addEventListener('click', function(){this.parentNode.remove();})

  var up = element.querySelector("#up");
  up.onclick = function(){
    var parent = this.parentNode;
    var container = parent.parentNode;
    if (parent.previousElementSibling){
    container.insertBefore(parent, parent.previousElementSibling);
    }
  }

  var down = element.querySelector("#down");
  down.onclick = function(){
    var parent = this.parentNode;
    var container = parent.parentNode;
    if (parent.nextElementSibling)
    container.insertBefore(parent, parent.nextElementSibling.nextElementSibling);
  }

}

save.onclick = function(){
  var div = document.createElement('div');
  document.getElementById('savebox').appendChild(div);
  var p = document.createElement('p');
  p.textContent += "{";
  var cont = document.getElementById('container');


  p.textContent += "}";
  div.appendChild(p);
}
