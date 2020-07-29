var ta;
var ws = null;
var bstart;
var bstop;



function exe_start() {
    if (ws = null) {
        ws = new WebSocket("ws://localhost:8077/test.kvo");
        ws.onopen = function () {
            ws.send("connecting");
        }
        ws.onclose = function (s) {
            console.log("close - ", s);
        }
        ws.onmessage = function (evt) {
            ta.innerHTML += evt.data;
        }
        bstart.disabled = true;
        bstop.disabled = false;
    }
}

function exe_stop() {
    ws.close(3001, "stopapplication");
    ws = null;
    bstart.disabled = false;
    bstop.disabled = true;

}

window.onload = function () {
    if (Modernizr.websockets) {
        WriteMessage("support", "yes");
        ta = document.getElementById("ta");
        bstart = document.getElementById("bstart");
        bstop = document.getElementById("bstop");
        bstart.disabled = false;
        bstop.disabled = true;
    }
}

function WriteMessage(id_span, text) {
    var span = document.getElementById(id_span);
    span.innerHTML = text;
}