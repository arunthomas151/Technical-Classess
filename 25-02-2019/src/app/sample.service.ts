import { Injectable } from '@angular/core';
import { student } from './student'
import { Observable, from, throwError } from 'rxjs';
import { HttpClient,HttpErrorResponse } from '@angular/common/http';
import { map,catchError } from 'rxjs/Operators'

@Injectable({
  providedIn: 'root'
})
export class SampleService {
student:student[];
  constructor(private http:HttpClient) { }
  store(student:student):Observable<student[]>{
    return this.http.post(`http://localhost/registration.php`,{data:student}).pipe(
      map((res)=>{
        this.student=res['data'];
        return this.student}),
        catchError(this.handleError))
  }
  private handleError(error:HttpErrorResponse){
    return throwError('Something Wrong');
  }
}
