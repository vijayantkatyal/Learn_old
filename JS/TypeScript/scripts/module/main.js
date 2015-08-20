var M;
(function (M) {
    function run() {
        console.log("hello world");
    }
    M.run = run;
    function run2(message) {
        console.log(message);
    }
    M.run2 = run2;
})(M || (M = {}));
