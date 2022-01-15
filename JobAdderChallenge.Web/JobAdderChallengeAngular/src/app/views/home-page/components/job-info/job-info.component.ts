import { Component, Input, OnInit } from '@angular/core';
import { MatCardModule } from '@angular/material/card';
import { CandidateModel } from 'src/app/models/candidateModel';
import { JobModel } from 'src/app/models/jobModel';

@Component({
  selector: 'app-job-info',
  templateUrl: './job-info.component.html',
  styleUrls: ['./job-info.component.scss']
})
export class JobInfoComponent implements OnInit {
  @Input()
  jobInfo!: JobModel;

  constructor() { }

  ngOnInit(): void {
    console.log("jobInfo: ", this.jobInfo);
  }

  getBestCandidate(jobId: number): void {
    console.log("jobId: ", jobId);
  }
}
