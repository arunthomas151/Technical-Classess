<?php

/*
|--------------------------------------------------------------------------
| Web Routes
|--------------------------------------------------------------------------
|
| Here is where you can register web routes for your application. These
| routes are loaded by the RouteServiceProvider within a group which
| contains the "web" middleware group. Now create something great!
|
*/

Route::get('/', function () {
    return view('welcome');
});

Route::get('/hello{id} ', function ($id) {
    return "<h1>Hello</h1>".$id;
});

Route::get('/about','PagesController@about');
Route::get('/registration', 'PagesController@registration');
Route::get('/', 'PagesController@index');
Route::get('/login','PagesController@login');
Route::resource('/datas','DatasController');