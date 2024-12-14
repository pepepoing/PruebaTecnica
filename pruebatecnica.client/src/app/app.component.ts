import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

interface Clients {
  id: number;
  name: string;
  phoneNumber: string;
  contry: string;
}

class PageResult<T> {
  public count: number = 0;
  public pageIndex: number = 0;
  public pageSize: number = 10;
  public items: T[] = [];
}


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent implements OnInit {
  public clients: Clients[] = [];
  public pageNumber: number = 1;
  public Count: number = 0;

  public spClients: Clients[] = [];
  public spPageNumber: number = 1;
  public spCount: number = 0;

  constructor(private http: HttpClient) {}

  ngOnInit() {
    this.getClients(1);
    this.getSpClients(1);
  }

  getClients(pageNumber: number) {
    this.http.get<PageResult<Clients>>('/clientsdata?page=' + pageNumber).subscribe(result => {
      this.clients = result.items;
      this.pageNumber = result.pageIndex;
      this.Count = result.count;
    }, error => console.error(error));
  }

  getSpClients(spPageNumber: number) {
    this.http.get<PageResult<Clients>>('/SPClientsData?page=' + spPageNumber).subscribe(result => {
      this.spClients = result.items;
      this.spPageNumber = result.pageIndex;
      this.spCount = result.count;
    }, error => console.error(error));
  }

  public onPageChange = (pageNumber: number) => {
    this.getClients(pageNumber);
  }

  public onSpPageChange = (spPageNumber: number) => {
    this.getSpClients(spPageNumber);
  }


  title = 'Prueba Técnica';
}
