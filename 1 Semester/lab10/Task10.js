var curtains = document.getElementById("container");
curtains.addEventListener('click', () =>{
  curtains.style.animation = "moveUp 1s 1 forwards ease-in-out";
})

var lamp = document.getElementById("lamp");
var turn = document.getElementById("switch");
lamp.addEventListener('mousedown', () =>{
  turn.style.animation = "light 0.1s 1 forwards ease-in-out";
})
lamp.addEventListener('mouseup', () =>{
  turn.style.animation = "light2 0.1s 1 forwards ease-in-out";
})
var light = document.getElementById("light");
var stage = document.getElementById("stage");
var bln = false;
lamp.addEventListener('click', ()=>{
  if (bln == false){
  light.style.animation = "turnOn 0.2s 1 forwards ease-in-out";
  stage.style.animation = "appear 0.2s 1 forwards ease-in-out";
  }
  else if(bln == true){
    light.style.animation = "turnOff 0.2s 1 forwards ease-in-out";
    stage.style.animation = "disappear 0.2s 1 forwards ease-in-out";
  }

  if (bln == false) bln = true;
  else bln = false;
})

var pigeon = document.getElementById("pigeon");
var rabbit = document.getElementById("rabbit");
pigeon.addEventListener('click', () =>{
  pigeon.style.animation = "hidePigeon 0.5s 1 forwards ease-in-out";
  setTimeout(() => {rabbit.style.animation = "showRabbit 0.5s 1 forwards ease-in-out";}, 500);
})
rabbit.addEventListener('click', () =>{
  rabbit.style.animation = "hideRabbit 0.5s 1 forwards ease-in-out";
  setTimeout(() => {  pigeon.style.animation = "showPigeon 0.5s 1 forwards ease-in-out"; }, 500);
})
