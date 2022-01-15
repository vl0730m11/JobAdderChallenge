import { NgModule } from "@angular/core";
import { RouterModule, Routes } from "@angular/router";
import { HomePageComponent } from "./home-page.component";

const routes: Routes = [
  {
    path: '',
    component: HomePageComponent,
    data: {
      title: 'HomePage'
    },
    children: [
      {
      }
    ]
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class HomePageRoutingModule { }
