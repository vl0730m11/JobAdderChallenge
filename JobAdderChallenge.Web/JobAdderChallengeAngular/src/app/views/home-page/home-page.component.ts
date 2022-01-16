import { Component, OnInit } from '@angular/core';
import { Observable, Subscription } from 'rxjs';
import { JobModel } from 'src/app/models/jobModel';
import { RecruitmentService } from 'src/app/services/recruitment.service';

@Component({
  selector: 'app-home-page',
  templateUrl: './home-page.component.html',
  styleUrls: ['./home-page.component.scss']
})
export class HomePageComponent implements OnInit {
  private sub: Subscription = new Subscription();
  jobList: JobModel[] = [];
  isLoading: boolean = false;

  constructor(
    private service: RecruitmentService
  ) { }

  ngOnInit(): void {
    this.isLoading = true;
    this.sub = this.service.getJobList().subscribe((res) => {
      this.jobList = res.data;
      //console.log("this.jobList: ", this.jobList);
      this.isLoading = false;
    });
  }

}
