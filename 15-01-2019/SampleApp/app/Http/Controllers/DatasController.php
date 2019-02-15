<?php

namespace App\Http\Controllers;
use App\Data;
use Illuminate\Http\Request;

class DatasController extends Controller
{
    /**
     * Display a listing of the resource.
     *
     * @return \Illuminate\Http\Response
     */
    public function index()
    {
        $dbdata=Data::all();
        //print_r($dbdata);
        return view('data.index',compact('dbdata'));
    }

    /**
     * Show the form for creating a new resource.
     *
     * @return \Illuminate\Http\Response
     */
    public function create()
    {
        return view('data.create');
    }

    /**
     * Store a newly created resource in storage.
     *
     * @param  \Illuminate\Http\Request  $request
     * @return \Illuminate\Http\Response
     */
    public function store(Request $request)
    {
       // print_r($request->get('uname'));
        $value=new Data([
            'name'=>$request->get('uname'),
            'email'=>$request->get('email'),
            'password'=>$request->get('pword')
        ]);
        $value->save();
    }

    /**
     * Display the specified resource.
     *
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function show($id)
    {
        //
    }

    /**
     * Show the form for editing the specified resource.
     *
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function edit($id)
    {
        $value=Data::find($id);
        return view('data.edit',compact('value'));
    }

    /**
     * Update the specified resource in storage.
     *
     * @param  \Illuminate\Http\Request  $request
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function update(Request $request, $id)
    {
        $result=Data::find($id);
        $result->name=$request->get('uname');
        $result->email=$request->get('email');
        $result->password=$request->get('pword');
        $result->save();
        $dbdata=Data::all();
        //print_r($dbdata);
        return view('data.index',compact('dbdata'));
    }

    /**
     * Remove the specified resource from storage.
     *
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function destroy($id)
    {
        $result=Data::find($id); 
        $result->delete();
        return redirect('\datas');
    }
}
