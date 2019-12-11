var metre;

var jour=0;

for (metre=-50;metre<0;metre+=3){
    if (metre>=-49){
        metre+=-2;

    }
    jour++;

    document.write("la grenoiille est a "+ metre + " mètre "+jour+" jour "+"<br>" );
}
document.write("la grenouille est sorti");