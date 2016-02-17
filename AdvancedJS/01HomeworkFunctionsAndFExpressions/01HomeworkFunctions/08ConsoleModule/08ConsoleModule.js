var specialConsole = (function () {
    var placeholder = /{\d+}/g;

    function writeLine() {
        var message = substitute(arguments);
        console.log(message);
    }

    function writeError() {
        var message = substitute(arguments);
        console.error(message);
    }

    function writeWarning() {
        var message = substitute(arguments);
        console.warn(message);
    }

    function writeInfo() {
        var message = substitute(arguments);
        console.info(message);
    }

    function substitute(args) {
        var message = args[0];
        if (args.length === 1) {
            if (typeof (message) !== 'string') {
                message = message.toString();
            }
            return message;
        }
        else {
            if (typeof (message) !== 'string') {
                throw new TypeError("No string format given!");
            }
            else {
                var placeholders = message.match(placeholder).sort(function (a, b) {
                    a = Number(a.substring(1, a.length - 1));
                    b = Number(b.substring(1, b.length - 1));
                    return a - b;
                });
                if (placeholders.length !== (args.length - 1)) {
                    throw new RangeError("Incorrect amount of parameters given!");
                }
                else {
                    for (var i = 0; i < placeholders.length; i++) {
                        var number = Number(placeholders[i].substring(1, placeholders[i].length - 1));
                        if (number !== i) {
                            throw new RangeError("Incorrect placeholders given!");
                        }
                        else {
                            if (typeof (args[i+1] !== 'string')) {
                                args[i+1] = args[i+1].toString();
                            }
                            message = message.replace(placeholders[i], args[i+1])
                        }
                    }
                    return message;
                }
            }
        }
    }

    return{
        writeLine: writeLine,
        writeInfo: writeInfo,
        writeWarning: writeWarning,
        writeError: writeError
    }
})();

specialConsole.writeLine("Message: hello");
specialConsole.writeLine("Message: {0}", "hello");
specialConsole.writeLine("Object: {0}", {
    name: "Gosho",
    toString: function() {
        return this.name;
    }
});
specialConsole.writeError("Error: {0}", "A fatal error has occurred.");
specialConsole.writeWarning("Warning: {0}", "You are not allowed to do that!");
specialConsole.writeInfo("Info: {0}", "Hi there! Here is some info for you.");
specialConsole.writeError("Error object: {0}", {
    msg: "An error happened",
    toString: function() {
        return this.msg;
    }
});
