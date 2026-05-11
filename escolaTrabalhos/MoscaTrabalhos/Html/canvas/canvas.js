var canvas = document.querySelector("canvas");
canvas.width = window.innerWidth;
canvas.height = window.innerHeight;

var c = canvas.getContext('2d');

let squares = [];
for (let bananas = 0; bananas < 10; bananas++) {
    squares.push({
        x: Math.random() * (window.innerWidth - 100),
        y: Math.random() * (window.innerHeight - 100),
        dx: (Math.random() - 0.5) * 4,
        dy: (Math.random() - 0.5) * 4,
        angle: 0,
        rotationSpeed: (Math.random() - 0.5) * 0.1,
        color: `rgb(0, ${Math.floor(Math.random() * 256)}, 0)`
    });
}

let lines = [];
for (let laranjas = 0; laranjas < 10; laranjas++) {
    lines.push({
        x1: Math.random() * window.innerWidth,
        y1: Math.random() * window.innerHeight,
        x2: Math.random() * window.innerWidth,
        y2: Math.random() * window.innerHeight,
        dx: (Math.random() - 0.5) * 2,
        dy: (Math.random() - 0.5) * 2,
        width: Math.random() * 10,
        color: `rgb(${Math.floor(Math.random() * 256)}, 0, 0)`
    });
}

let circles = [];
for (let mamoes = 0; mamoes < 30; mamoes++) {
    circles.push({
        x: Math.random() * (window.innerWidth - 100),
        y: Math.random() * (window.innerHeight - 100),
        dx: (Math.random() - 0.5) * 3,
        dy: (Math.random() - 0.5) * 3,
        radius: Math.random() * 40 + 20,
        color: `rgb(0, 0, ${Math.floor(Math.random() * 256)})`
    });
}

function animate() {
    c.clearRect(0, 0, canvas.width, canvas.height);

    // Animate squares
    squares.forEach(square => {
        square.x += square.dx;
        square.y += square.dy;
        square.angle += square.rotationSpeed;

        if (square.x < 0 || square.x > window.innerWidth - 100) square.dx *= -1;
        if (square.y < 0 || square.y > window.innerHeight - 100) square.dy *= -1;

        c.save();
        c.translate(square.x + 50, square.y + 50);
        c.rotate(square.angle);
        c.fillStyle = square.color;
        c.fillRect(-50, -50, 100, 100);
        c.restore();
    });

    // Animate lines
    lines.forEach(line => {
        line.x1 += line.dx;
        line.y1 += line.dy;
        line.x2 += line.dx;
        line.y2 += line.dy;

        c.beginPath();
        c.moveTo(line.x1, line.y1);
        c.lineTo(line.x2, line.y2);
        c.strokeStyle = line.color;
        c.lineWidth = line.width;
        c.stroke();
    });

    // Animate circles
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