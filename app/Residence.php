<?php

namespace App;

use Illuminate\Database\Eloquent\Model;

class Residence extends Model
{
    protected $hidden = ['profileImage','idUser','idPreference','idLocation','remember_token','created_at','updated_at'];
    
    protected $primaryKey = "idResidence";

    protected $table = 'residence';

    protected $fillable = ['idUser','idPreference','idLocation','title','description','address','observation','rent','profileImage'];

    public $timestamps = false;

    public function location()
    {
        return $this->belongsTo('App\Location','idLocation');
    } 

    public function preference()
    {
        return $this->belongsTo('App\Preference','idPreference');
    } 

    public function user()
    {
        return $this->belongsTo('App\User','idUser');
    } 
    //varios para 1 no inverso =D
    public function residenceImages()
    {
        return $this->hasManyThrough('App\residenceImage','App\residence',
                                     'idResidence','idResidence', 'idResidence');
    } 

    public function matches()
    {
        return $this->hasManyThrough('App\Match','App\residence',
                                     'idResidence','idResidence', 'idResidence');
    } 

    public function profileImageResidence(){
        return $this->hasOne('App\ResidenceImage', 'idResidenceImage','profileImage');
    }
    
}
