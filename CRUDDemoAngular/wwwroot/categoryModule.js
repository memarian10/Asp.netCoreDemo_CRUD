﻿//قرار شد یک اسکریپ خودمان داشته باشیم به نام کتگوری ماژول
//بخش انگولار پروژه
//در واقع در این بخش داریم از طریق ای جکس، به کنترلر ای پی آی مراجعه می کنیم و از آن یک جی سون تحویل می گیریم و در متغیر قرار میدهیم.


//اسکوپ یعنی در داخل دیو ایندکس چون که اپ و کنترلر در این سکشن تعریف شده است
(function () {
    angular.module('categoryModulezzzzz', [])
        .controller('categoryControllerzzzz', function ($scope, $http) {
            //$scope eshare be UI
            //اولین اتفاقی که باید بیفتد این است که مراجعه کند به اون ای پی آی و کتگوری ها را بگیرد و در متغیری قراردهد
            //در اینجا به وسیله دالر اچ تی تی پی دات گت مراجعه می کنیم به ای پی آی
            $http.get('/API/GetCategories')

                //وقتی که جواب آماده شد، در متغیر کتگوریز، قرار میدهم ریزالت دات دیتا را
                .then(function (result) {
                    $scope.categoriess = result.data;
                });

            $scope.deleteCategory = function (categoryId) {//اگر در اسکوپ تابعی به نام دیلیت کتگوری دیدی، کتگوری آی آن را بگیر
                //alert(categoryId);
                //حالا باید این کتگوری آی دی را به عملیات حذف ارسال کنیم
                $http.get('/API/DeleteCategories/' + categoryId)//این آدرس به فایل ای پی آی و تابع دیلیت کتگوریز موجود در آن اشاره دارد
                    .then(function (result){
                        $scope.categoriess = result.data;
                });

            };

        });

    //حالا باید در فایل اچ تی ام ال، اسکوپ را تعریف کنیم



  



})();