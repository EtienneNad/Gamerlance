var  imageId1;
var  imageId2;
var imageSrc1;
var imageSrc2;
var click=1;
var image;
var victoire;
var tabRandom;
var randNum;
var l;
var tmp;
var z
$('#boutonRecommencer').click(function () {
    click=1;
 tabRandom =["images/1.jpg","images/2.jpg","images/3.jpg","images/4.jpg","images/5.jpg","images/6.jpg","images/7.jpg","images/8.jpg","images/9.jpg",];

    for (l=0;l<tabRandom.length;l++) {
        randNum = Math.floor(Math.random() * 8);

          tmp = tabRandom[l];
        tabRandom[l] = tabRandom[randNum];
        tabRandom[randNum] = tmp ;

    }
for(z=1;z<=9;z++){
    $('#image'+z).attr("src",tabRandom[z-1]);
}


});

$('#boutonTricher').click(function () {
    for(var i=1;i<=9;i++){
$('#image'+i).attr("src","images/"+i+".jpg");
}
});

$('.img-fluid').click(function () {
    if (click===1){
        imageId1= $(this).attr("id");
        imageSrc1= $(this).attr("src");

        click=2;
    }
   else if (click===2){
        imageId2= $(this).attr("id");
        imageSrc2= $(this).attr("src");
        $('#' + imageId1).attr("src",imageSrc2);
        $('#'+imageId2).attr("src",imageSrc1);

        click=1;
        verificationVictoire();
    victoire=0;
        }

});
 function verificationVictoire(){
   for(var j=1;j<10;j++){
     image=[$('#image'+j).attr("id"),$('#image'+j).attr("src")];
     if (image[0]==="image"+j && image[1]==="images/"+j+".jpg"){
         victoire++;
     }
     if(victoire===9){
         for(var k=1;k<10;k++){
             $("#image"+k).attr("src","images/victoire.jpg");
         }
     }
   }
 }

