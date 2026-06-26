var canvas = document.querySelector("canvas");
canvas.width = window.innerWidth;
canvas.height = window.innerHeight;

var c = canvas.getContext('2d')
c.fillStyle = 'rgb(0, 0, 0)';
c.fillRect(0,0,window.innerWidth,window.innerHeight);

c.beginPath();
c.arc(60, 60, 60, 0, Math.PI * 2, false);
c.strokeStyle = 'rgb(0, 100, 0)';
c.stroke();