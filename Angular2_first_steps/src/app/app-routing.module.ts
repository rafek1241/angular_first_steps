import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { NotFoundComponent } from './not-found/not-found.component';
import { MovieListComponent } from './movie-list/movie-list.component';
import { MovieDetailComponent } from './movie-detail/movie-detail.component';
import { DirectorListComponent } from './director-list/director-list.component';
import { DirectorDetailComponent } from './director-detail/director-detail.component';


const appRoutes: Routes = [
  { path: 'movies/:id', component: MovieDetailComponent },
  { path: 'movies', component: MovieListComponent },
  { path: 'directors/:id', component: DirectorDetailComponent },
  { path: 'directors', component: DirectorListComponent },
  { path: '', redirectTo: '/movies', pathMatch: 'full' },
  { path: '**', component: NotFoundComponent }
];

@NgModule({
  imports: [
    RouterModule.forRoot(
      appRoutes,
      {
        enableTracing: true, // <-- debugging purposes only
      }
    )
  ],
  exports: [
    RouterModule
  ],
})
export class AppRoutingModule { }


/*
Copyright 2017-2018 Google Inc. All Rights Reserved.
Use of this source code is governed by an MIT-style license that
can be found in the LICENSE file at http://angular.io/license
*/
