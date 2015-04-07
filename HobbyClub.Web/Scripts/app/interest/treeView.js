//Tree view model for Interest

angular.module("treeViewModule", []);

angular.module("App", ["treeViewModule", "ngSanitize"])

.controller("treeViewCtrl", function ($scope) {
    //test data
    $scope.tree = {
        name: "N1", childrens:
            [{
                name: "N11", childrens:
                  [{ name: "N111" },
                    { name: "N112", childrens: [{ name: "N1121" }, { name: "N1122" }, { name: "N1123" }] },
                    { name: "N113" }
                  ]
            },
              { name: "N12" },
              { name: "N13", childrens: [{ name: "N131" }, { name: "N132" }] }
            ]
    };

    $scope.hideInner = function (name) {
        var hideSelect = document.querySelector("ul#" + name + ">li>ul>li");
        if (!hideSelect)
            return;
        var hideClass = hideSelect.getAttribute("class");
        var forHide = document.querySelectorAll(
            "ul#" + name + ">li>ul>li>div" + //div
            ", ul#" + name + ">li>ul>li" //li
            );
        for (var i = 0; i < forHide.length; ++i) {
            forHide[i].setAttribute("class", (hideClass == "animated myFadeInDown" || hideClass == "animated") ? "animated myFadeOutDown" : "animated myFadeInDown");
        }
        var forRotate = document.querySelector("ul#" + name + ">li>div>i");
        if (!forRotate) {
            window.alert('nothing');
            return;
        }
        var forRotateClass = forRotate.getAttribute("class");
        forRotate.setAttribute("class", (forRotateClass == "animated rotateDown" || forRotateClass == "animated") ? "animated rotateUp" : "animated rotateDown");
    };
    //always down

    $scope.generateTreeHtml = function (root, level) {
        if (!root || !angular.isNumber(level)) return "";

        //start ul
        var resStr = '<ul id = "objectId' + root.name + '" >';
        
        //start li
        var firstAnimType;
        if (level == 0)
            firstAnimType = "myFadeInDown";
        else
            firstAnimType = "myFadeOutDown";

        resStr += '<li class="animated' + firstAnimType + '"><div class="animated ' + firstAnimType + '" ng-click="hideInner(\'objectId' + root.name + '\')">';
        //start main object
        if (root.childrens)
            resStr += '<i class="animated">&#9660</i>';
        resStr += '<img src="/Content/Images/logo.png" ></img>';
        resStr += 'super new text for our new super new site without any meaning la lala a ' + root.name;
        //end main object
        resStr += '</div>';
        if (root.childrens) {
            var addStr = "";

            root.childrens.forEach(function (item, ind, arr) {
                addStr += $scope.generateTreeHtml(item, ++level);
             });

            resStr += addStr;
        }
        //end li
        resStr += "</li>"
        // end ul
        resStr += "</ul>";
        return resStr;
    };
})

.directive('compile', ['$compile', function ($compile) {
    return function (scope, element, attrs) {
        scope.$watch(
          function (scope) {
              return scope.$eval(attrs.compile);
          },
          function (value) {
              element.html(value);
              $compile(element.contents())(scope);
          }
       )
    };
}]);

//End of tree view model for Interest