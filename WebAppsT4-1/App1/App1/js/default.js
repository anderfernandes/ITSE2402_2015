(function () {
    "use strict";

    var app = WinJS.Application;
    var activation = Windows.ApplicationModel.Activation;

    app.onactivated = function (args) {
        if (args.detail.kind === activation.ActivationKind.launch) {

            args.setPromise(WinJS.UI.processAll().
                done(function () {

                }));
        }
    };
    (function () {
        "use strict";

        var app = WinJS.Application;
        var activation = Windows.ApplicationModel.Activation;

        app.onactivated = function (args) {
            if (args.detail.kind === activation.ActivationKind.launch) {

                args.setPromise(WinJS.UI.processAll().
                    done(function () {

                        // Add an event handler to the button.
                        document.querySelector("#requestPosition").addEventListener("click",
                            requestPosition);

                    }));
            }
        };

        var nav = null;

        function requestPosition() {
            if (nav == null) {
                nav = window.navigator;
            }

            var geoloc = nav.geolocation;
            if (geoloc != null) {
                geoloc.getCurrentPosition(successCallback, errorCallback);
            }

        }

        function successCallback(position) {
            document.getElementById("latitude").innerHTML =
                position.coords.latitude;
            document.getElementById("longitude").innerHTML =
                position.coords.longitude;

        }

        function errorCallback(error) {
            var strMessage = "";

            // Check for known errors
            switch (error.code) {
                case error.PERMISSION_DENIED:
                    strMessage = "Access to your location is turned off. " +
                        "Change your settings to turn it back on.";
                    break;
                case error.POSITION_UNAVAILABLE:
                    strMessage = "Data from location services is " +
                        "currently unavailable.";
                    break;
                case error.TIMEOUT:
                    strMessage = "Location could not be determined " +
                        "within a specified timeout period.";
                    break;
                default:
                    break;
            }

            document.getElementById("status").innerHTML = strMessage;
        }

        app.start();
    })();
})();