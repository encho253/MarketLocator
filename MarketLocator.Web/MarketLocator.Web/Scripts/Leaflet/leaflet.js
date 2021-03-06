﻿var map = L.map('mapid').setView([48.1486, 17.1077], 13);

L.tileLayer('https://api.tiles.mapbox.com/v4/{id}/{z}/{x}/{y}.png?access_token=pk.eyJ1IjoibWFwYm94IiwiYSI6ImNpejY4NXVycTA2emYycXBndHRqcmZ3N3gifQ.rJcFIG214AriISLbB6B5aw', {
    maxZoom: 18,
    id: 'mapbox.streets'
}).addTo(map);

var markerArray = [];

function addPoint() {
    var field = document.getElementById('data');
    var trafficData = JSON.parse(field.value);

    trafficData.forEach(function (element) {
        markerArray.push(L.marker([element.CellLat, element.CellLong]).bindPopup(element.ANumber + " LatLng(" + element.CellLat + ", " + element.CellLong + ")").openPopup());
    });

    var group = L.featureGroup(markerArray).addTo(map);
    map.fitBounds(group.getBounds());
}

var popup = L.popup();

function onMapClick(e) {
    popup
        .setLatLng(e.latlng)
        .setContent("You clicked the map at " + e.latlng.toString())
        .openOn(map);
}

map.on('click', onMapClick);