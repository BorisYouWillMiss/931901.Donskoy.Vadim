var left = document.getElementById("left");
left.onclick = function(){
  document.getElementById("omg1").style.display = "inline-block";
  document.getElementById("omg2").style.display = "none";
  document.getElementById("picholder1").style.width = "90%";
  document.getElementById("omg1").style.maxWidth = "400px";
  document.getElementById("picholder2").style.width = "10%";

}
var both = document.getElementById("both");
both.onclick = function(){
  document.getElementById("omg1").style.display = "inline-block";
  document.getElementById("omg2").style.display = "inline-block";
  document.getElementById("picholder1").style.width = "50%";
  document.getElementById("picholder2").style.width = "50%";
}
var right = document.getElementById("right");
right.onclick = function(){
  document.getElementById("omg1").style.display = "none";
  document.getElementById("omg2").style.display = "inline-block";
  document.getElementById("picholder2").style.width = "90%";
  document.getElementById("omg2").style.maxWidth = "400px";
  document.getElementById("picholder1").style.width = "10%";
}
