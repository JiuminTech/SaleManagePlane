/*选项卡控制*/
function setTab(name,cursel,n){
for(i=1;i<=n;i++){
var menu=document.getElementById(name+i);
var con=document.getElementById("con"+name+i);
    menu.className = i == cursel ? "over Selected" : " ";
    menu.parentElement.className = i == cursel ? "over Selected" : " ";
con.style.display=i==cursel?"block":"none";
}
}
function setTabUrl(name, cursel, n,url) {
    for (i = 1; i <= n; i++) {
        var menu = document.getElementById(name + i);        
        menu.className = i == cursel ? "over Selected" : " ";        
    }
    //var frame = docuemt.getElementById('mainIfram');
    $("#mainIfram").attr("src", url);
    $("#mainIfram").reload();
}

function slctType(id, cursel, n, x) {
    for (i = 1; i <= n; i++) {
        var type = id + x + "" + i;
        var menu = document.getElementById(type);
        var con = document.getElementById("edit" + type);
        menu.className = i == cursel ? "over Selected" : " ";
        menu.style.background = i == cursel ? "lightblue" : "white ";
        con.style.display = i == cursel ? "block" : "none";
        
    }
    $("#edit"+id+x).attr("type", cursel);
}

function slctTypeX(id, cursel, n, x) {
    for (i = 1; i <= n; i++) {
        var type = id + x + "" + i;
        //alert("edit" + type);
        var menu = document.getElementById(type);
        var con = document.getElementById("edit" + type);
        menu.className = i == cursel ? "over Selected" : " ";
        menu.style.background = i == cursel ? "lightblue" : "white ";
        con.style.display = i == cursel ? "block" : "none";
        //alert($(con).attr("style"));
        //alert($(con).attr("id"));
    }
    $("#edit" + id + x).attr("type", cursel);
}
function openWin(url,title) {
    art.dialog.open(url, { title: title, width: '1200px', height: '800px', left: '50%', top: '20px', lock: 'true' }, false);
}

function useroperlogsave(user, obj, type, desc) {
    $.ajax({
        type: "post",
        url: '../xwservice/webconfig/handle/useroperlogsave.ashx',
        cache: false,
        async: true,
        data: { "username": user, "operobj": obj, "opertype": type, "operdesc": desc },
        complete: (function (data) {
            console.log(desc);
        }),
        error: (function (data) {
            alert(JSON.stringify(data));

        })

    })
}
function openLog(obj) {
    art.dialog.open('../xwservice/webconfig/showoperlog.aspx?obj=' + obj, { title: '操作日志', width: '900px', height: '600px', left: '50%', top: '20px', lock: 'true' }, false);
}