import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { RouterOutlet } from '@angular/router';

interface Product {
  name: string;
  description: string;
  price: number;
}

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [CommonModule, FormsModule],
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  newProduct: Product = { name: '', description: '', price: 0 };
  products: Product[] = [];

  addProduct() {
    if (this.newProduct.name && this.newProduct.description && this.newProduct.price > 0) {
      this.products.push({ ...this.newProduct });
      this.newProduct = { name: '', description: '', price: 0 };
    }
  }

  deleteProduct(index: number) {
    this.products.splice(index, 1);
  }
}