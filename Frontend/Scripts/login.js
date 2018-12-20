var a;
$(document).ready(function () {
    const loginForm = document.createElement("div");
    loginForm.innerHTML = ` <div class="loginForm">
                                <center>
                                    <h2>
                                        Log ind
                                    </h2>
                                    <input id="username" placeholder="Brugernavn" required />
                                    <input id="password" placeholder="Kodeord" type="password" required />
                                    <input id="loginBtn" type="submit" value="Log ind"/>
                                    <span id="loginClose">X</span>
                                </center>
                            </div>`;
    //document.body.appendChild(loginForm);
    document.body.insertBefore(loginForm, document.body.firstChild.nextSibling);
    $("#btnLogin").click(function () {
        $(".loginForm").fadeToggle("fast");
        if ($(".loginForm").is(":visible")) {

        }
    });

    document.addEventListener("keydown", function (evt) {
        evt = evt || window.event;
        if (evt.keyCode == 27) {
            $(".loginForm").fadeOut("fast");
        }
    });

    $("#loginClose").click(function () {
        $(".loginForm").fadeToggle("fast");
    });

    $("#loginBtn").click(function () {
        
        $("#username").val("");
        $("#password").val("");
        alert("You tried to login");
    });

    $("#picUpload").click(function () {
        var output = document.createElement("img");
        var upload = $(document.createElement("input"));
        upload.attr("type", "file");
        /*
        upload.change(function (input) {
            var reader = new FileReader();
            reader.onload = function (e) {
                output.src = e.target.result;
            }
            reader.readAsDataURL(input.files[0]);
        });
        */
        a = upload.trigger("click");
        inputter(a);
        console.log(a); 
        /*
        var image = document.createElement("img");
        image.src = a[0].files[0];
        */
        return;
    });
});
