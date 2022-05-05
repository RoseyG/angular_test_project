import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {
  
  public startStory(){
    this.router.navigate(['/story']);
  }

  constructor( private router: Router ) { }

}
