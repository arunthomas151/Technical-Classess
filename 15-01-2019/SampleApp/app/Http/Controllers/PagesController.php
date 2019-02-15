<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;

class PagesController extends Controller
{
    public function index(){
        return view('welcome');
    }

    public function about(){
        return view('pages.about');
    }
    public function login(){
        return view('pages.login');
    }
    public function registration(){
        return view('pages.registration');
    }
    
}

