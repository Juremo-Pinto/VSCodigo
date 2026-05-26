var canvas = document.querySelector("canvas");
canvas.width = window.innerWidth;
canvas.height = window.innerHeight;

var c = canvas.getContext('2d');

var mouseX = 0;
var mouseY = 0;
var x = 250, y = 150;

canvas.addEventListener("mousemove", function(event) {
    const react = canvas.getBoundingClientRect();
    mouseX = event.clientX - react.left;
    mouseY = event.clientY - react.top;
})
let squares = [];
// Creates 10 of
for (let bananas = 0; bananas < 10; bananas++) {
    squares.push({
        // Position and Shape
        x: Math.random() * (window.innerWidth - 100),
        y: Math.random() * (window.innerHeight - 100),
        // Velocity
        dx: (Math.random() - 0.5) * 4,
        dy: (Math.random() - 0.5) * 4,
        angle: 0,
        // Rotation Speed [duh]
        rotationSpeed: (Math.random() - 0.5) * 0.1,
        // Color
        color: `rgb(0, ${Math.floor(Math.random() * 256)}, 0)`
    });
}

let lines = [];
for (let laranjas = 0; laranjas < 10; laranjas++) {
    lines.push({
        // Position and shape
        x1: Math.random() * window.innerWidth,
        y1: Math.random() * window.innerHeight,
        x2: Math.random() * window.innerWidth,
        y2: Math.random() * window.innerHeight,
        // Shape
        width: Math.random() * 10,
        // Velocity
        dx: (Math.random() - 0.5) * 2,
        dy: (Math.random() - 0.5) * 2,
        angle: 0,
        rotationSpeed: (Math.random() - 0.5) * 0.1,
        // Color
        color: `rgb(${Math.floor(Math.random() * 256)}, 0, 0)`
    });
}

let circles = [];
for (let mamoes = 0; mamoes < 30; mamoes++) {
    circles.push({
        // Starting Position
        x: Math.random() * (window.innerWidth - 100),
        y: Math.random() * (window.innerHeight - 100),
        // Shape
        radius: Math.random() * 40 + 20,
        // Velocity
        dx: (Math.random() - 0.5) * 3,
        dy: (Math.random() - 0.5) * 3,
        // Color
        color: `rgb(0, 0, ${Math.floor(Math.random() * 256)})`
    });
}

function animate() {
    c.clearRect(0, 0, canvas.width, canvas.height);

    x += (mouseX - x) * 0.1;
    y += (mouseY - y) * 0.1;

    c.beginPath();
    c.arc(x, y, 15, 0, Math.PI * 2);
    c.fillStyle = "black";
    c.fill();

    squares.forEach(square => {
        square.x += square.dx;
        square.y += square.dy;
        square.angle += square.rotationSpeed;

        // Colision
        const squareCenterX = square.x + 50;
        const squareCenterY = square.y + 50;
        const dxMouse = mouseX - squareCenterX;
        const dyMouse = mouseY - squareCenterY;
        const cosA = Math.cos(square.angle);
        const sinA = Math.sin(square.angle);
        const localX = dxMouse * cosA + dyMouse * sinA;
        const localY = -dxMouse * sinA + dyMouse * cosA;

        if (Math.abs(localX) < 50 && Math.abs(localY) < 50) {
            square.dx *= -1;
            square.dy *= -1;
            square.x += square.dx * 2;
            square.y += square.dy * 2;
        }

        if (square.x < 0 || square.x > window.innerWidth - 100) square.dx *= -1;
        if (square.y < 0 || square.y > window.innerHeight - 100) square.dy *= -1;

        c.save();
        c.translate(squareCenterX, squareCenterY);
        c.rotate(square.angle);
        c.fillStyle = square.color;
        c.fillRect(-50, -50, 100, 100);
        c.restore();
    });

    lines.forEach(line => {
        //Draws lines
        line.x1 += line.dx;
        line.y1 += line.dy;
        line.x2 += line.dx;
        line.y2 += line.dy;
        line.angle += line.rotationSpeed;

        // Colision for lines
        const lineCenterX = (line.x1 + line.x2) / 2;
        const lineCenterY = (line.y1 + line.y2) / 2;
        const lineCenterTwoX = (line.x2 - line.x1) / 2;
        const lineCenterTwoY = (line.y2 - line.y1) / 2;
        const cos = Math.cos(line.rotationSpeed);
        const sin = Math.sin(line.rotationSpeed);
        const rx = lineCenterTwoX * cos - lineCenterTwoY * sin;
        const ry = lineCenterTwoX * sin + lineCenterTwoY * cos;

        line.x1 = lineCenterX - rx;
        line.y1 = lineCenterY - ry;
        line.x2 = lineCenterX + rx;
        line.y2 = lineCenterY + ry;

        if (line.x1 < 0 || line.x1 > window.innerWidth || line.x2 < 0 || line.x2 > window.innerWidth) line.dx *= -1;
        if (line.y1 < 0 || line.y1 > window.innerHeight || line.y2 < 0 || line.y2 > window.innerHeight) line.dy *= -1;

        c.beginPath();
        c.moveTo(line.x1, line.y1);
        c.lineTo(line.x2, line.y2);
        c.strokeStyle = line.color;
        c.lineWidth = line.width;
        c.stroke();
    });

    circles.forEach(circle => {
        circle.x += circle.dx;
        circle.y += circle.dy;

        if (circle.x - circle.radius < 0 || circle.x + circle.radius > window.innerWidth) circle.dx *= -1;
        if (circle.y - circle.radius < 0 || circle.y + circle.radius > window.innerHeight) circle.dy *= -1;

        c.beginPath();
        c.arc(circle.x, circle.y, circle.radius, 0, Math.PI * 2);
        c.fillStyle = circle.color;
        c.fill();
    });

    requestAnimationFrame(animate);
}

animate();