﻿function drawChart(densityCanvas, XLabels, YValues)
{

    //var XLabels = Newtonsoft.Json.JsonConvert.SerializeObject(Data.Select(x => x.Date.ToString()).ToList());
    //var YValues = Newtonsoft.Json.JsonConvert.SerializeObject(Data.Select(x => x.TempValue).ToList());



    //var densityData = {
    //    label: 'Density of Planet (kg/m3)',
    //    data: [5427, 5243, 5514, 3933, 1326, 687, 1271, 1638],
    //    backgroundColor: 'rgba(0, 99, 132, 0.6)',
    //    borderColor: 'rgba(0, 99, 132, 1)',
    //    yAxisID: "y-axis-density"
    //};

    //var gravityData = {
    //    label: 'Gravity of Planet (m/s2)',
    //    data: [3.7, 8.9, 9.8, 3.7, 23.1, 9.0, 8.7, 11.0],
    //    backgroundColor: 'rgba(99, 132, 0, 0.6)',
    //    borderColor: 'rgba(99, 132, 0, 1)',
    //    yAxisID: "y-axis-gravity"
    //};

    //var planetData = {
    //    labels: ["Mercury", "Venus", "Earth", "Mars", "Jupiter", "Saturn", "Uranus", "Neptune"],
    //    datasets: [densityData, gravityData]
    //};

    var tempValuesData = {
        label: 'Temperature (Co)',
        data: YValues,
        backgroundColor: 'rgba(0, 99, 132, 0.6)',
        borderColor: 'rgba(50, 99, 132, 1)',
        yAxisID: "y-axis-temp"
    };

    var TemperaturesData = {
        labels: XLabels,
        datasets: [tempValuesData]
    };

    var chartOptions = {
        scales: {
            xAxes: [{
                barPercentage: 1,
                categoryPercentage: 0.6
            }],
            yAxes: [{
                id: "y-axis-temp"
            }]
        }
    };

   

    var barChart = new Chart(densityCanvas, {
        type: 'bar',
        data: TemperaturesData,
        options: chartOptions
    });
}