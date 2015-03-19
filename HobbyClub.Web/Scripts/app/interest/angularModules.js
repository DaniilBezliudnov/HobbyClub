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
        var hideClass = document.querySelector("ul#" + name + ">li>ul>li").getAttribute("class");
        var forHide = document.querySelectorAll(
            "ul#" + name + ">li>ul>li>span" + //span
            ", ul#" + name + ">li>ul>li>span>a" //a
             + ", ul#" + name + ">li>ul>li" //li
            );
        for (var i = 0; i < forHide.length; ++i) {
            forHide[i].setAttribute("class", (hideClass == "animated myFadeInDown" || hideClass == "animated") ? "animated myFadeOutDown" : "animated myFadeInDown");
        }
    };

    //юзаем хтмл + потом меняем классы
    $scope.generateTreeHtml = function (root, level) {
        if (!root || !angular.isNumber(level)) return "";

        //start ul
        var resStr = '<ul ';
        //add classes
        resStr += "id = \"objectId" + root.name + "\""
        resStr += ">"

        //start li
        if (level == 0)
            resStr += '<li class="animated myFadeInDown"><span class="animated myFadeInDown"><a class="animated myFadeInDown" href="" ng-click="hideInner(\'objectId' + root.name + '\')">' + root.name + '</a></span>';//main object
        else
            resStr += '<li class="animated myFadeOutDown"><span class="animated myFadeOutDown"><a class="animated myFadeOutDown" href="" ng-click="hideInner(\'objectId' + root.name + '\')">' + root.name + '</a></span>';//main object
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