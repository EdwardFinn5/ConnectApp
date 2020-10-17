import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'ICF Connect';
  colUsers: any;

  constructor(private http: HttpClient) {}

  ngOnInit() {
    this.getColUsers();
  }

  getColUsers() {
    this.http.get('https://localhost:5001/api/colusers').subscribe(response => {
      this.colUsers = response;
    }, error => {
      console.log(error);
    });
  }
}




