/*
 * name：Application
 * descript：.
 * Author : Roy
*/
function Application() {
    var formArray = new Array();
    var _self = {
        forms: formArray,
        created: false,
        defaultLanguage: "EN",
        addForm: function (htmlForm) {
            this.forms.push(htmlForm);
        }
    }
    return _self;
}
var application = new Application();
document.onreadystatechange = function () {
    if (!application.created) {
        application.created = true;
        main();
    }
};

/*
 * name：Control
 * descript：all visual control inherite from control.
 * Author : Roy
*/
function Control(ParentControl,htmlType,htmlClass)
{
    var parentElement;
    if (ParentControl == null) {
        parentElement = document.body;
    }
    else {
        parentElement = ParentControl.self;
        
    }
    var htmlElement = document.createElement(htmlType);
    parentElement.appendChild(htmlElement);
    var controlArray = new Array();
    var _self = 
        {
            //properties
            align: "none",        // enum:none,left,top,right,bottom,center;
            alignment: "left",    // left,right,center
            anchors: "left,top",  //[left,top,right,bottom]
            name: "",
            color: "white",
            css: "",
            className: htmlClass,
            fontName: "Courier New",
            fontSize: 10,
            fontColor:"black",
            parent: ParentControl,
            self: htmlElement,
            popupMenu: null,
            left:"0px",
            top:"0px",
            width : "100px",
            height: "60px",
            hint: "",
            type: "control",
            index: ParentControl ? 0 : parentElement.childNodes.length,
            controls: controlArray,
            controlCount: 0,
            text : "",
            //methods
            resize: function () {
                /*计算子控件位置*/
                var leftArray = new Array();
                var topArray = new Array();
                var rightArray = new Array();
                var bottomArray = new Array();
                var centerArray = new Array();
                for (var i = 0; i < this.controlCount; i++) {
                    switch (this.controls[i].align) {
                        case "left": leftArray.push(this.controls[i]); break;
                        case "top": topArray.push(this.controls[i]); break;
                        case "right": rightArray.push(this.controls[i]); break;
                        case "bottom": bottomArray.push(this.controls[i]); break;
                        case "center": centerArray.push(this.controls[i]); break;
                    }
                }
                var ALeft = 0, ATop = 0, ABottom = 0, ARight = 0;
                for (var i = 0; i < topArray.length; i++) {
                    var control = topArray[i];
                    control.self.style.left = ALeft + "px";
                    control.self.style.top = ATop + "px";
                    control.self.style.width = this.self.clientWidth + "px";
                    control.self.style.height = control.height + "px";
                    ATop += control.self.clientHeight;
                }
                for (var i = 0; i < bottomArray.length; i++) {
                    var control = bottomArray[i];
                    control.self.style.width = this.self.clientWidth + "px";
                    control.self.style.height = control.height + "px";
                    control.self.style.left = ALeft + "px";
                    control.self.style.top = (this.self.clientHeight - control.self.clientHeight - ABottom) + "px";
                    ABottom += control.self.clientHeight;
                }
                for (var i = 0; i < leftArray.length; i++) {
                    var control = leftArray[i];
                    control.self.style.left = ALeft + "px";
                    control.self.style.top = ATop + "px";
                    control.self.style.width = control.width + "px";
                    control.self.style.height = (this.self.clientHeight - ATop - ABottom) + "px";
                    ALeft += control.self.clientWidth;
                }
                for (var i = 0; i < rightArray.length; i++) {
                    var control = rightArray[i];
                    control.self.style.width = control.width + "px";
                    control.self.style.height = (this.self.clientHeight - ATop - ABottom) + "px";
                    control.self.style.left = (this.self.clientHeight - control.self.clientHeight - ARight) + "px";
                    control.self.style.top = ATop + "px";
                    ARight += control.self.clientWidth;
                }
                /*居中时，每个子控件大小一致*/
                for (var i = 0; i < centerArray.length; i++) {
                    var control = centerArray[i];
                    control.self.style.left = ALeft + "px";
                    control.self.style.top = ATop + "px";
                    control.self.style.width = (this.self.clientWidth - ALeft - ARight) + "px";
                    control.self.style.height = (this.self.clientHeight - ATop - ABottom) + "px";
                    break;
                }
            },
            setControlPos: function () {
                if (ParentControl == null) {
                    if (this.align == "left") {
                        htmlElement.style.left = "0px";
                        htmlElement.style.top = "0px";
                        htmlElement.style.height = parentElement.clientHeight + "px";
                    }
                    if (this.align == "top") {
                        htmlElement.style.left = "0px";
                        htmlElement.style.top = "0px";
                        htmlElement.style.width = parentElement.clientWidth + "px";
                    }
                    if (this.align == "right") {
                        htmlElement.style.left = (parentElement.clientWidth - htmlElement.clientWidth) + "px";
                        htmlElement.style.top = "0px";
                        htmlElement.style.height = parentElement.clientHeight + "px";
                    }
                    if (this.align == "bottom") {
                        htmlElement.style.left = "0px";
                        htmlElement.style.top = (parentElement.clientHeight - htmlElement.clientHeight) + "px";
                        htmlElement.style.width = parentElement.clientWidth + "px";
                    }
                    if (this.align == "center") {
                        htmlElement.style.left = "0px";
                        htmlElement.style.top = "0px";
                        htmlElement.style.width = this.width + "px";
                        htmlElement.style.height = this.height + "px";
                    }
                }
                if (this.align == "none") {
                    htmlElement.style.left = this.left;
                    htmlElement.style.top = this.top;
                    htmlElement.style.width = this.width;
                    htmlElement.style.height = this.height;
                }
                this.resize();
            },
            setAnchors:function(){

            },
            create: function () {
                
                htmlElement.style.backgroundColor = this.color;
                htmlElement.style.position = "absolute";
                htmlElement.style.padding = parentElement.style.padding;
                htmlElement.style.marginTop = parentElement.offsetTop + "px";
                htmlElement.style.marginLeft = parentElement.offsetLeft + "px";
                htmlElement.style.fontFamily = this.fontName;
                htmlElement.style.fontSize = this.fontSize;
                htmlElement.style.color = this.fontColor;
                htmlElement.style.textAlign = this.alignment;
                var cssValue = htmlElement.getAttribute("style");
                htmlElement.setAttribute("style", cssValue+this.css);
                
                this.setControlPos();
            },
            update: function () {
                this.create();
                if (this.parent) this.parent.update();
            }
        }
    return _self;
};

function HtmlForm(parentElement) {
    var base = new Control(parentElement, "div", "HtmlForm");
    application.addForm(base);
    base.width = document.body.clientWidth;
    base.height = document.body.clientHeight;
    base.create();
    base.Refresh = function () {
        base.update();
    }
    return base;
};

function HtmlPanel(parentElement) {
    var base = new Control(parentElement, "div", "HtmlPanel");
    parentElement.controls.push(base);
    parentElement.controlCount = parentElement.controls.length;
    base.create();
    base.Refresh = function () {
        if (base.text != "")
            base.self.innerHTML = this.text;
        base.update();
    }
    return base;
};

function HtmlFrame(parentElement) {
    var base = new Control(parentElement, "iframe", "HtmlFrame");
    parentElement.controls.push(base);
    parentElement.controlCount = parentElement.controls.length;
    base.create();
    base.setUrl = function (url) {
        base.self.src = url;
    }
    base.Refresh = function () {
        base.self.frameBorder = "0";
        base.update();
    }
    return base;
}

function HtmlButton(parentElement) {
    var base = new Control(parentElement, "button", "HtmlButton");
    parentElement.controls.push(base);
    parentElement.controlCount = parentElement.controls.length;
    base.width = 50;
    base.height = 50;
    base.create();
    base.alignment = "center";
    base.text = "";
    base.imageUrl = ""
    base.onclick = null;
    base.Refresh = function () {
        base.self.innerHTML = "<img src='" + base.imageUrl + "' />" + base.text;
        if (base.onclick != null)
            base.self.onclick = base.onclick;
        base.update();
    }
    return base;
}