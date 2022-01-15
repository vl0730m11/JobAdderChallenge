export class CandidateModel {
  candidateId!: number;
  name!: string;
  skillTags!: string[];
}

export class BestCandidateModel extends CandidateModel {
  score: number = 0;
  maxScore: number = 0;
}
