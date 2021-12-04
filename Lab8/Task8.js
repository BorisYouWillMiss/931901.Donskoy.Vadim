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
    
  }

  var down = element.querySelector("#down");
  down.onclick = function(){

  }

}

save.onclick = function(){

}
