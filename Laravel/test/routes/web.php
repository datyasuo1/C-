<?php

use Illuminate\Support\Facades\Route;
use App\Models\Post;
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
Route::get('home','HomeController@showWelcome');
Route::get('/', function () {
//    return 'Welcome home by Yasuo';
    return view('welcome');
});

Route::get('profile/{name}','ProfileController@showProfile');

Route::get('about','AboutController@showDetails');

//Route::get('about',function(){
//    return 'About Yasuooooo';
//});

Route::get('about/directions',function(){
    return 'About directions Yasuooooo';
});

Route::any('submit-form',function (){
    return'Process Form';
});

Route::get('about/{theSubject}','AboutController@showSubject');

//Route::get('about/{theSubject}',function ($theSubject){
//    return $theSubject.' content goes here';
//});

Route::get('about/{name}/{action}',function ($action,$name){
    return "$action thang $name ";
});

Route::get('where',function (){
    return Redirect:: to('about');
//    return \Illuminate\Support\Facades\Redirect::to('about');
});
/*---------------------------------------------------------------------------------*/
Route::get('/insert',function (){
   DB::insert('insert into posts(title,body,is_admin) values(?,?,?)',['PHP with Laravel','Laravel is the best fremework ',0] );
   return 'done';
});

Route::get('/read/{id}',function ($id){
    $result = DB::select('select * from posts where id = ?',[$id]);
//    return $result;
    foreach ($result as $post){
//        return $post->title;
        return $post->body;
    }
});

Route::get('update',function (){
    $updated = DB::update('update posts set title ="New Title hihi" where  id = ?',[1]);
    return $updated;
});

Route::get('/delete/{id}',function ($id){
    $delete = DB::delete('delete from posts where id = ?',[$id]);
    return $delete;
});

Route::get('readAll',function (){
    $posts = Post::all();
    foreach ($posts as $p){
        echo $p->title." <br>".$p->body;
        echo "<br>";

    }
});
/*test nhe*/
//Route::get('readAll/{need}',function ($need){
//    $posts = Post::all($need);
//    foreach ($posts as $p){
//        return $p->$need;
//    }
//});

Route::get('findId',function (){
   $posts = Post::where('id','>=',1)
   ->where('title','PHP with Laravel')
   ->where('body','like','%Laravel%')
   ->orderBy('id','desc')
   ->take(10)
   ->get();
   foreach ($posts as $p){
       echo $p ->title;
       echo "<br>";
   }
});

Route::get('insertORM',function (){
    $p = new Post;
    $p->title = 'insert ORM';
    $p->body ='inserted done done ORM';
    $p->is_admin =1;
    $p->save();
});

Route::get('updateORM/{id}',function ($id){
    $p = Post::where('id',$id)->first();
    $p->title = 'update :))';
    $p->body = 'update yay';
    $p->save;
});

Route::get('deleteORM',function (){
   Post:: where('id','>=',9)
       ->delete();
});

Route::get('destroyORM',function (){
    Post::destroy(13);
});
