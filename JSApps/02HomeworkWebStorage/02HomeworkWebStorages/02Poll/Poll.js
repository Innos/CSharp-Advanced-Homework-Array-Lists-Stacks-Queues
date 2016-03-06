$(document).ready(function(){

    //timer
    var timer = $("#timer");
    var time;
    if(localStorage.timeLeft){
        time = Number(localStorage.getItem('timeLeft'));
    }
    else {
        time = 300;
    }
    printTime(time);

    var id = window.setInterval(function(){
        time--;
        if(time == 0){
            submit();
        }
        printTime(time);
        localStorage.setItem('timeLeft',time);
    },1000);


    //fill radio buttons
    if(localStorage.answer1){
        $("#" + localStorage.getItem('answer1')).attr("checked",true);
    }
    if(localStorage.answer2){
        $("#" + localStorage.getItem('answer2')).attr("checked",true);
    }
    if(localStorage.answer3){
        $("#" + localStorage.getItem('answer3')).attr("checked",true);
    }


    //write current selected answers in storage
    var checboxes1 = $("#question1 input");
    checboxes1.on("click",function(event){
        localStorage.setItem('answer1',event.target.id);
    });

    var checboxes2 = $("#question2 input");
    checboxes2.on("click",function(event){
        localStorage.setItem('answer2',event.target.id);
    });

    var checboxes3 = $("#question3 input");
    checboxes3.on("click",function(event){
        localStorage.setItem('answer3',event.target.id);
    });

    // on page reload check if quiz is completed
    if(localStorage.submit){
        window.clearInterval(id);
        $("input").attr('disabled',true);
        $('submit').off();
        displayAnswers();
    }

    //if not tie event listeners back
    if(!localStorage.submit){
        $("#submit").on("click",submit);
        $("input").attr("disabled",false);
    }

    //submit function
    function submit(){
        localStorage.timeLeft = time;
        window.clearInterval(id);
        localStorage.submit = true;

        $("input").attr('disabled',true);
        $('submit').off();

        displayAnswers();
    }


    //DOM manipulation and time calculation
    function printTime(time){
        var seconds = (time % 60).toString();
        seconds.length < 2 ? seconds = "0" + seconds: seconds;
        timer.text(parseInt(time/ 60) + ":" + seconds);
    }

    // display answers
    function displayAnswers(){
        var question1 = $("#question1");
        var question2 = $("#question2");
        var question3 = $("#question3");
        var answer1 = $("<p>");
        if(localStorage.getItem('answer1') === "Pesho"){
            answer1.text("Correct");
            answer1.css({'color':'green'});
        }
        else{
            answer1.text("Incorrect");
            answer1.css({'color':'red'});
        }

        var answer2 = $("<p>");
        if(localStorage.getItem('answer2') === "DataStructures"){
            answer2.text("Correct");
            answer2.css({'color':'green'});
        }
        else{
            answer2.text("Incorrect");
            answer2.css({'color':'red'});
        }

        var answer3 = $("<p>");
        if(localStorage.getItem('answer3') === "JSApplications"){
            answer3.text("Correct");
            answer3.css({'color':'green'});
        }
        else{
            answer3.text("Incorrect");
            answer3.css({'color':'red'});
        }

        question1.append(answer1);
        question2.append(answer2);
        question3.append(answer3);
    }

    //clear storage gunction
    $('#clear').on("click",function(){
        localStorage.removeItem('submit');
        localStorage.removeItem('answer1');
        localStorage.removeItem('answer2');
        localStorage.removeItem('answer3');
        localStorage.removeItem('timeLeft');
    })
});




