import { Component } from "@angular/core";
import { FormControl } from "@angular/forms";

@Component({
  selector: "app-root",
  templateUrl: "./app.component.html",
  styleUrls: ["./app.component.css"]
})
export class AppComponent {
  shouldRun = true;
  opened: boolean;
  toggleMenu() {
    this.opened = !this.opened;
  }
}
