function card_producto(n) {
    for (let i = 0; i < n; i++) {
        let elemento = document.querySelector(".producto-muestra");
        let dupNode = elemento.cloneNode(true);
        let elementoConjuntos = document.querySelector(".producto-conjunto");
        elementoConjuntos.appendChild(dupNode);
    }
}

if(screen.width <= 425) {
    card_producto(3);
} else if(screen.width <= 1024){
    card_producto(7);
} else {
    card_producto(8);
}

if(screen.width <= 320){
    document.querySelector(".producto-conjunto").classList.remove("ms-4")
}
