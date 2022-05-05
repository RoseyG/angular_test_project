import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-story',
  templateUrl: './story.component.html',
})
export class StoryComponent {
  private http: HttpClient;
  private baseUrl: string;
  public scenes: Scene[] = [];

  public currentScene = 0;

  public sceneGenerator() {
    this.currentScene++;
    this.http.get<Scene>(this.baseUrl + 'scene').subscribe(result => {
      this.scenes.push(result);
    }, error => console.error(error)); 
  }

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.http = http;
    this.baseUrl = baseUrl;
    this.sceneGenerator();
  }
}

interface Scene {
  sceneText: string;
  sceneId: number;
}