import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-story',
  templateUrl: './story.component.html',
})
export class StoryComponent {
  public pages: StoryPage[] = [];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<StoryPage[]>(baseUrl + 'storypage').subscribe(result => {
      this.pages = result;
    }, error => console.error(error)); 
  }
}

interface StoryPage {
  pageText: string;
  pageNum: number;
}