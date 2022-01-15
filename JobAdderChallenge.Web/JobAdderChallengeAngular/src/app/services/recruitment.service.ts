import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { JobModel } from '../models/jobModel';

@Injectable({
  providedIn: 'root'
})
export class RecruitmentService {
  private readonly _url = environment.api.addr + "/api/Recruitment/";

  constructor(private _httpService: HttpClient) { }

  getJobList(): Observable<any> {
    const url = this._url + "getJobList";
    return this._httpService.get<any>(url)
  }

  getBestCandidate(jobId: number): Observable<any> {
    const url = this._url + "getBestCandidate";
    return this._httpService.get<any>(url + '/?jobId=' + jobId)
  }
}
