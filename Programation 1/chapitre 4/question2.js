
var  temperatureFahrenheit;
var temperaturecelcius;

for(temperatureFahrenheit=-40;temperatureFahrenheit<=40;temperatureFahrenheit+=5){
    temperaturecelcius=0.556*(temperatureFahrenheit-32);

    document.write(temperaturecelcius+"°C"+"<br>");
}
