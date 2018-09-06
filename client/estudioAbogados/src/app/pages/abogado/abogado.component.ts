import { Component, OnInit } from '@angular/core';
import { Abogado, AbogadoService } from '../../services/abogado.service';

@Component({
  selector: 'app-abogado',
  templateUrl: './abogado.component.html',
  styleUrls: ['./abogado.component.css']
})
export class AbogadoComponent implements OnInit {

  items: Abogado[] = [];

  constructor(private _abogadoService: AbogadoService) {
    this._abogadoService.getItems().subscribe(res => {
      this.items = res;
      console.log(this.items);
    });
  }

  ngOnInit() {
  }

}
