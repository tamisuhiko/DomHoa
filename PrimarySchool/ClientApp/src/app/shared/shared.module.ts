import { NgModule } from "@angular/core";
import { CommonModule } from "@angular/common";
import { MatSidenav } from "@angular/material";

@NgModule({
  imports: [CommonModule, MatSidenav],
  exports: [MatSidenav],
  declarations: []
})
export class SharedModule {}
