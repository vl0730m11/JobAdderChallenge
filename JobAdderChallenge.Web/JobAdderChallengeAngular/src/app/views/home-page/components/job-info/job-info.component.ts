import { Component, Input, OnInit } from '@angular/core';
import { MatCardModule } from '@angular/material/card';
import { Subscription } from 'rxjs';
import { BestCandidateModel, CandidateModel } from 'src/app/models/candidateModel';
import { JobModel } from 'src/app/models/jobModel';
import { RecruitmentService } from 'src/app/services/recruitment.service';
import { MatProgressSpinnerModule } from '@angular/material/progress-spinner';

@Component({
  selector: 'app-job-info',
  templateUrl: './job-info.component.html',
  styleUrls: ['./job-info.component.scss']
})
export class JobInfoComponent implements OnInit {
  @Input()
  jobInfo!: JobModel;
  bestCandidate!: BestCandidateModel;
  private sub: Subscription = new Subscription();
  isLoading: boolean = false;

  constructor(
    private service: RecruitmentService
  ) { }

  ngOnInit(): void {
  }

  getBestCandidate(jobId: number): void {
    this.isLoading = true;
    this.sub = this.service.getBestCandidate(jobId).subscribe((res) => {
      this.bestCandidate = res.data;
      this.isLoading = false;
    });
  }
}
