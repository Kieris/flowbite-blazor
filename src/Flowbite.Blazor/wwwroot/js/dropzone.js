﻿export const initializeFileDropZone = (dropZoneElement) => {
    return new FileDropZoneHandler(dropZoneElement);
};
const hover = 'drop-hover';
class FileDropZoneHandler {
    constructor(dropZone) {
        this._disposed = false;
        this._dropZone = null;
        this._delay = -1;
        this._dropZone = dropZone;
        this._handlers = [
            ['dragenter', this.onDragHover.bind(this)],
            ['dragover', this.onDragHover.bind(this)],
            ['dragleave', this.onDragLeave.bind(this)],
            ['drop', this.onDrop.bind(this)],
            ['paste', this.onPaste.bind(this)],
            ['click', this.onClick.bind(this)]
        ];
        this._handlers.forEach(handler => dropZone.addEventListener(handler[0], handler[1]));
    }
    cancelDelay() {
        if (this._delay !== -1)
            clearTimeout(this._delay);
        this._delay = -1;
    }
    onDragHover(e) {
        let _a;
        e.preventDefault();
        this.cancelDelay();
        (_a = this._dropZone) === null || _a === void 0 ? void 0 : _a.classList.add(hover);
    }
    onDragLeave(e) {
        e.preventDefault();
        this.cancelDelay();
        this._delay = setTimeout(() => {
            var _a;
            this._delay = -1;
            (_a = this._dropZone) === null || _a === void 0 ? void 0 : _a.classList.remove(hover);
        }, 10);
    }
    onDrop(e) {
        let _a;
        e.stopPropagation();
        e.preventDefault();
        this.cancelDelay();
        (_a = this._dropZone) === null || _a === void 0 ? void 0 : _a.classList.remove(hover);
        this.dispatch(e.dataTransfer);
    }
    onClick(e) {
        if (this._disposed === true)
            return;
        if (document.contains(this._dropZone) === false)
            return;
        let _a;
        const inputFileElement = (_a = this._dropZone) === null || _a === void 0 ? void 0 : _a.querySelector('input[type=file]');
        if (inputFileElement === null)
            throw new Error('');
        inputFileElement.click();
    }
    onPaste(e) {
        this.dispatch(e.clipboardData);
    }
    dispatch(data) {
        let _a;
        if (data === null)
            return;
        if (this._disposed === true)
            return;
        if (document.contains(this._dropZone) === false)
            return;
        const inputFileElement = (_a = this._dropZone) === null || _a === void 0 ? void 0 : _a.querySelector('input[type=file]');
        if (inputFileElement === null)
            throw new Error('');
        inputFileElement.files = data.files;
        const event = new Event('change', { bubbles: true });
        inputFileElement.dispatchEvent(event);
    }
    dispose() {
        if (this._disposed === true)
            return;
        if (this._dropZone !== null) {
            this._handlers.forEach(handler => this._dropZone.removeEventListener(handler[0], handler[1]));
        }
        this._disposed = true;
        this._dropZone = null;
    }
}