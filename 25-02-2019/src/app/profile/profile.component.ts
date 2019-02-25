import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms'
import { SampleService } from '../sample.service';
import { student } from '../student';
@Component({
  selector: 'app-profile',
  templateUrl: './profile.component.html',
  styleUrls: ['./profile.component.css']
})
export class ProfileComponent implements OnInit {
  student =new student();
  error:any;
  sucess:any;
  constructor(private obj:SampleService) { }

  ngOnInit() {
  }
    registration(f: NgForm){
      this.obj.store(this.student).subscribe(
        data=>{
          this.sucess="Registration ok";
          f.reset();
        },(err)=>{this.error= err;}
      )
  
    }
  
  }