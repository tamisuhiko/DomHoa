import { Routes, RouterModule } from "@angular/router";
import { HomeComponent } from "./home/home.component";
import { CounterComponent } from "./counter/counter.component";
import { FetchDataComponent } from "./fetch-data/fetch-data.component";
import { AdministratorsComponent } from "./administrators/administrators.component";

export const appRoutes: Routes = [
  { path: "", component: HomeComponent, pathMatch: "full" },
  { path: "counter", component: CounterComponent },
  { path: "fetch-data", component: FetchDataComponent },
  {
    path: "administrators",
    component: AdministratorsComponent,
    pathMatch: "full"
  },
  {
    path: "**",
    component: CounterComponent
  }
];
