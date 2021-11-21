import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { EmpprojectService } from '../empproject.service';
import { empdetails } from '../login/Models/employee';
import { empproject } from '../login/Models/empproject';

@Component({
  selector: 'app-empproject',
  templateUrl: './empproject.component.html',
  styleUrls: ['./empproject.component.css']
})
export class EmpprojectComponent implements OnInit {
  emplist:Array<empproject>=[];
  constructor(private p:EmpprojectService,private r:Router) { }

  ngOnInit(): void {
    this.p.getEvents().subscribe(data => {
          this.emplist = data;
   });
        
  }

}

// export class LeavemanagementComponent implements OnInit {
  
//   leavelist:Array<leavemanagent>=[];
//   constructor(private p:LeavemanagementService,private r:Router) { }
 
//     ngOnInit(): void {
//       this.p.getEvents().subscribe(data => {
//         this.leavelist = data;
//       });
  
//     }
    

 
// }
