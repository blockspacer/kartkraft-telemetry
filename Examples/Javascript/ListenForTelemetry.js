var flatbuffers = require("./flatbuffers/flatbuffers").flatbuffers;
var KartKraft = require("./kartkraft/Frame_generated").KartKraft; // Generated by `flatc`.
var dgram = require("dgram");
var server = dgram.createSocket("udp4");

var PORT = 5000;
var HOST = "127.0.0.1";

//
//Print message when server is ready
//
server.on("listening", function() {
  var address = server.address();
  console.log(
    "UDP Server listening on " + address.address + ":" + address.port
  );
});

//
//When a message is received, print out its contents
//
server.on("message", function(message, remote) {
  var buf = new flatbuffers.ByteBuffer(message);
  var frame = KartKraft.Frame.getRootAsFrame(buf);
  if (frame) {
    console.log("Received frame of length " + buf.capacity());

    //Get motion/data/session objects from the frame
    motion = frame.motion();
    dash = frame.dash();
    session = frame.session();

    //Check for presence of motion data and write to log if it exists
    if (motion) {
      console.log(
        "    motion data: " + motion.pitch(),
        motion.roll(),
        motion.yaw(),
        motion.accelerationX(),
        motion.accelerationY(),
        motion.accelerationZ(),
        motion.tractionLoss()
      );
    }

    //Check for presence of dash data and write to log if it exists
    if (dash) {
      console.log(
        "    dash data: " + dash.speed(),
        dash.rpm(),
        dash.steer(),
        dash.throttle(),
        dash.brake(),
        dash.gear(),
        dash.pos(),
        dash.bestLap()
      );
    }

    //Check for presence of session data and write to log if it exists
    if (session) {
      console.log("    session data: ");
    }
  }
});

server.bind(PORT, HOST);
