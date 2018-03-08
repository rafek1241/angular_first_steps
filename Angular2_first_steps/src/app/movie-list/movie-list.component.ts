import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs/Observable';
import { Movie } from '../movie';

import 'rxjs/add/operator/map';

@Component({
  selector: 'app-movie-list',
  templateUrl: './movie-list.component.html',
  styleUrls: ['./movie-list.component.css']
})
export class MovieListComponent implements OnInit {
  movies: Array<Movie>;

  constructor(private http: HttpClient) {

    http.get<Movie[]>('api/movies')
      .subscribe(res => this.movies = res);

  }

  ngOnInit() {

  }

}
