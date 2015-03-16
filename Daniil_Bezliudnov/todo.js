angular.module("addModule", [])
.factory("archiveService", [function(){
	var archive = [];
	
	return function(elements){
		archive.push(elements);
		window.alert(elements.length);
	};
}]).filter("del1", function(){
	return function(input){
	if(!angular.isString(input))
		return input;
	else
		return input.slice(1, input.length);
}});

angular.module("mainApp", ["addModule", "ngSanitize"])
.controller("TodoCtrl", function($scope, archiveService) {

  $scope.todos = [
    {text:'learn angular', done:true},
    {text:'build an angular app', done:false}];
	
  $scope.archiveListVisible = "false";
  $scope.archiveList = [];
  
  $scope.addTodo = function() {
    $scope.todos.push({text:$scope.todoText, done:false});
    $scope.todoText = '';
  };
 
  $scope.remaining = function() {
    var count = 0;
    angular.forEach($scope.todos, function(todo) {
      count += todo.done ? 0 : 1;
    });
    return count;
  };
  
  $scope.showArchive = function() {
	$scope.archiveListVisible = !$scope.archiveListVisible;
  };
  
  $scope.archive = function() {
    var oldTodos = $scope.todos;
    $scope.todos = [];
	
    angular.forEach(oldTodos, function(todo) {
      if (!todo.done) 
		$scope.todos.push(todo);
	  else
		archiveService(todo);
    });
  };
})

.controller("treeViewCtrl", function($scope){
//test data
	$scope.tree = {name : "N1", childrens :
		[ {name : "N11", childrens : 
		  [ {name : "N111"},
			{name : "N112", childrens : [{name : "N1121"}, {name : "N1122"}, {name : "N1123"}]},
			{name : "N113"}
		  ]}, 
		  {name : "N12"}, 
		  {name : "N13", childrens : [{name : "N131"} , {name : "N132"}]}
		]};
	
	$scope.hideInner = function(name){
		var hideClass = document.querySelector("ul#" + name + " ul").getAttribute("class");
		var forHide = document.querySelectorAll("ul#" + name + ">li>ul");
		for  (var i = 0; i < forHide.length; ++i)
		{
		    forHide[i].setAttribute("class", hideClass == "animated fadeOut" ? "animated fadeIn" : "animated fadeOut");
		    //forHide[i].fadeIn();
		}
	};
	
	//юзаем хтмл + потом меняем классы
	$scope.generateTreeHtml = function(root, level) {
		if(!root || !angular.isNumber(level)) return "";
		
		//start ul
		var resStr = '<ul class="animated fadeIn"';
		//add classes
		resStr += "id = \"objectId"+ root.name +"\""
		resStr += ">"
		
		//start li
		resStr += '<li><span><a href="" ng-click="hideInner(\'objectId' + root.name + '\')">' + root.name + '</a></span>';//main object
		if(root.childrens)
		{
			var addStr = "";
			
			root.childrens.forEach(function(item, ind, arr) {
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
  return function(scope, element, attrs) {
    scope.$watch(
      function(scope) {
        return scope.$eval(attrs.compile);
      },
      function(value) {
        element.html(value);
        $compile(element.contents())(scope);
      }
   )};
}]);
