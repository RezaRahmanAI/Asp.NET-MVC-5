import { Component, OnInit, ChangeDetectorRef } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { Category } from '../../models/category.model';
import { CategoryService } from '../../services/category-service';

@Component({
  selector: 'app-category',
  standalone: true,
  imports: [CommonModule, FormsModule],
  templateUrl: './category-component.html',
})
export class CategoryComponent implements OnInit {
  categories: Category[] = [];

  category: Category = {
    id: 0,
    name: '',
    isActive: true,
  };

  constructor(
    private categoryService: CategoryService,
    private cdr: ChangeDetectorRef // 🔥
  ) {}

  ngOnInit(): void {
    this.loadCategories();
  }

  loadCategories() {
    this.categoryService.getAll().subscribe((res) => {
      this.categories = res;
      this.cdr.detectChanges(); // 🔥 force UI update
    });
  }

  save() {
    if (this.category.id === 0) {
      this.categoryService.add(this.category).subscribe(() => {
        this.loadCategories();
        this.reset();
      });
    } else {
      this.categoryService.update(this.category.id, this.category).subscribe(() => {
        this.loadCategories();
        this.reset();
      });
    }
  }

  edit(cat: Category) {
    this.category = { ...cat };
  }

  delete(id: number) {
    if (!confirm('Are you sure?')) return;

    this.categoryService.delete(id).subscribe(() => {
      this.loadCategories();
    });
  }

  reset() {
    this.category = {
      id: 0,
      name: '',
      isActive: true,
    };
  }
}
