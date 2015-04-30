/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
var app = {
    // Application Constructor
    initialize: function() {
        this.bindEvents();
    },
    // Bind Event Listeners
    //
    // Bind any events that are required on startup. Common events are:
    // `load`, `deviceready`, `offline`, and `online`.
    bindEvents: function() {
        document.addEventListener('deviceready', this.onDeviceReady, false);
    },
    // deviceready Event Handler
    //
    // The scope of `this` is the event. In order to call the `receivedEvent`
    // function, we must explicitly call `app.receivedEvent(...);`
    onDeviceReady: function() {
        app.receivedEvent('deviceready');
    },
    // Update DOM on a Received Event
    receivedEvent: function(id) {
        var parentElement = document.getElementById(id);
        var listeningElement = parentElement.querySelector('.listening');
        var receivedElement = parentElement.querySelector('.received');

        listeningElement.setAttribute('style', 'display:none;');
        receivedElement.setAttribute('style', 'display:block;');

        console.log('Received Event: ' + id);
    }
};

// DOT SMASHER CODE
var score = 0;
var aWidth;
var aHeight;
var timer;

function detectHit() {
    score += 1;
    scoreLabel.innerHTML = "Score: " + score;
}

function setGameAreaBounds() {
    if (document.all) {
        aWidth = document.body.clientWidth;
        aHeight = document.body.clientHeight;
    }
    else {
        aWidth = innerWidth;
        aHeight = innerHeight;
    }
    aWidth -= 30;
    aHeight -= 95;
    document.getElementById("gameArea").style.width = aWidth;
    document.getElementById("gameArea").style.height = aHeight;
    aWidth -= 74;
    aHeight -= 74;
    moveDot();
}

function moveDot() {
    var x = Math.floor(Math.random() * aWidth);
    var y = Math.floor(Math.random() * aHeight);
    if (x < 10) {
        x = 10;
    }
    if (y < 10) {
        y = 10;
    }
    document.getElementById("dot").style.left = x;
    document.getElementById("dot").style.top = y;
    clearTimeout(timer);
    timer = setTimeout("moveDot()", 1000);
}
