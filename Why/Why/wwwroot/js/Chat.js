

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
    let OtherUserss = OtherUser + Userr;
    var fromUser = $("#txtMainUser").val();
    var fromOtherUser = $("#txtOtherUserName").val();
    var message = $("#txtMessage").val();
    
    

    
    
    $.ajax({
        contentType: "application/json",
        dataType: "json",
        type: "get",
        url: "/Chat/ChatUserMessage/",
        data: { user: Userr, otherUser: OtherUser, users: userss, otherUsers: OtherUserss },
        success: function (data) {
            

            var object = jQuery.parseJSON(data);
            //fromOtherUserdan isim almam lazim ama gelmiyor oinun yerine email geliyor 
            $.each(object, (index, value) => {

                console.log(fromOtherUser + " = " + fromUser);
                if (Userr === value.ChatMessageFirstUserName ) {
                    var msg = fromUser + ": " + value.ChatMessageContent;
                    var li = document.createElement("li");
                    li.textContent = msg;
                    $("#list").prepend(li);
                }
                else {
                    var msg = fromOtherUser + ": " + value.ChatMessageContent;
                    var li = document.createElement("li");
                    li.textContent = msg;
                    $("#list").prepend(li);
                }

                
                
                
                

            })
            
        }

    });
    
    
});

