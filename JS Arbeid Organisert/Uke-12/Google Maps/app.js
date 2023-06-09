function initMap() {
    let mapTypeStylesArray = [
        {
            featureType: 'water',
            elementType: 'labels.text',
            stylers: [
                {
                    color: '#FF0000',
                }
            ]
            // https://developers.google.com/maps/documentation/javascript/style-reference
        },
    ];

    let mapOptions = {
        center: { lat: 41.881832, lng: -87.623177 }, // new google.maps.LatLng('41.881832', '-87.623177')
        zoom: 18, // Goes from 1 - 20
        // mapTypeId: 'satellite', // satellite, terrain, roadmap, hybrid
        mapTypeControlOptions: {
            mapTypeIds: ['roadmap']
        },
        // styles: mapTypeStylesArray,
        // mapId: '',
    };

    let map = new google.maps.Map(document.getElementById('map'), mapOptions);

    let markerOptions = [
        {
            position: { lat: 41.881832, lng: -87.623177 },
            optimized: true,
            draggable: true,
            animation: google.maps.Animation.DROP,
            // label: 'Ingen Adgang',
            // title: 'Terjes Private Basseng'
            // icon: {
            //     url: 'Terje.png',
            //     scaledSize: new google.maps.Size(38, 31),
            // }
            // map: map,
        },
        {
            position: { lat: 41.881832, lng: -86.623177 },
        }
    ];

    let marker = [
        new google.maps.Marker(markerOptions[0]),
        new google.maps.Marker(markerOptions[1]),
    ];

    const infoWindowOptions = {
        content: 'Ingen adgang!',
        // position: { lat: 41.881964, lng: -87.623177 },
        // pixelOffset: new google.maps.Size(0, -10)
        // maxWidth: 50,
    };

    const infoWindow = new google.maps.InfoWindow(infoWindowOptions);

    infoWindow.setContent(`
    <h1>Husk logg 📝</h1>
    `);

    const infoWindowOpenOptions = {
        map: map,
        anchor: marker[0],
        shouldFocus: false,
    };

    // infoWindow.open(infoWindowOpenOptions);

    marker[0].addListener('click', (googleMapsEvent) => {
        document.getElementById('info').innerHTML =
            'latitude: ' +
            googleMapsEvent.latLng.lat() +
            ' longitude: ' +
            googleMapsEvent.latLng.lng();
        infoWindow.open(infoWindowOpenOptions);
    });

    marker[0].setIcon({
        url: 'Terje.png',
        scaledSize: new google.maps.Size(38, 31),
    });
    // marker[0].setLabel('Terjes Private Basseng');
    marker[0].setTitle('Terjes Private Basseng');

    setTimeout(() => {
        marker[0].setAnimation(null);
    }, 4500);

    marker[0].setMap(map);
    marker[1].setMap(map);

    // marker.setMap(map);

    // map.setTilt(40);
    // map.setHeading(90);
}