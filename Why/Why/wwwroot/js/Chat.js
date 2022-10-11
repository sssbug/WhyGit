$("#btnSend").click(x => {
    var OtherUser = $("#txtOtherUser").val();
    var FirstUser = $("#txtFirstUser").val();
    var fromUser = $("#txtUser").val();
    var Userss = FirstUser + OtherUser;
    var message = $("#txtMessage").val();

    var msg = fromUser + ": " + message;
    var li = document.createElement("li");
    li.textContent = msg;
    $("#list").prepend(li);

    let mess = $("#txtMessage").val();
    $.ajax({
        contentType: "application/json",
        dataType: "json",
        type: "get",
        url: "/Chat/ChatCounter/",
        data: { msg: mess, Users: Userss, first: FirstUser, second: OtherUser },
        success: function (func) {
            console.log(func);
        }

    });


});

$("#btn").click(x => {
    let Userr = $("#txtUser").val();
    let OtherUser = $("#txtOtherUser").val();
    let userss = Userr + OtherUser;
    let listmess;


    $.ajax({
        contentType: "application/json",
        dataType: "json",
        type: "get",
        url: "/Chat/ChatUserMessage/",
        data: { user: Userr, otherUser: OtherUser, users: userss },
        success: function (func) {
            listmess = func;
        }

    });
});