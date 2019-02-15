import { Component } from '@angular/core';

@Component({
  selector: 'app-administrators',
  templateUrl: './administrators.component.html'
})
export class AdministratorsComponent {
  public currentCount = 0;

  public incrementCounter() {
    this.currentCount++;
  }
}
