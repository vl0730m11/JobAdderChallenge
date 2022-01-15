import { Component, Input, OnInit } from '@angular/core';
import { BestCandidateModel, CandidateModel } from 'src/app/models/candidateModel';

@Component({
  selector: 'app-candidate-info',
  templateUrl: './candidate-info.component.html',
  styleUrls: ['./candidate-info.component.scss']
})
export class CandidateInfoComponent implements OnInit {
  @Input() bestCandidate!: BestCandidateModel;

  constructor() { }

  ngOnInit(): void {
  }

}
